var express = require("express");
var app = express();
module.exports = app;

app.use('/exercisetracker', express.static("exercisetracker/public"));

app.get("/exercisetracker", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.get('/exercisetracker/hello', function(req, res) {
  res.json({ greeting: 'hello exercisetracker API' });
});

const bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({ extended: false }));

const mongoose = require("mongoose");

mongoose.connect(process.env.MONGO_URI, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});
/* END_ENVIRONMENT */

const Schema = mongoose.Schema;

const userSchema = new Schema({
  username: String,
});

const User = mongoose.model("User", userSchema);

app.get('/exercisetracker/users', async (req, res) =>{
  const us = await User.find({});
  res.send(us);  
});

app.post("/exercisetracker/users", async (req, res) => {
  const username = req.body.username;
  let u = await User.findOne({ username: username });
  if (!u) {
    u = await new User({
      username: username,
    }).save();
  }
  res.send(u);
});

const exerciseSchema = new Schema({
  username: String,
  description: String,
  duration: Number,
  date: Date,
});

const Exercise = mongoose.model("Exercise", exerciseSchema);

app.post("/exercisetracker/users/:_id/exercises", async (req, res) => {
  const u = await User.findById(req.params._id);
  if (!u) {
    res.send("User not found");
  } else {
    const date = req.body.date;
    const exercise = {
      username: u.username,
      description: req.body.description,
      duration: req.body.duration,
      date: date ? new Date(date) : new Date(),
    };
    
    await new Exercise(exercise).save();
    
    return res.json({
      _id: u._id,
      username: u.username,
      date: exercise.date.toDateString(),
      duration: parseInt(exercise.duration),
      description: exercise.description
    });
  }
});

app.get("/exercisetracker/users/:_id/logs", async (req, res) => {
  const u = await User.findById(req.params._id);
  if (!u) {
    res.send("User not found");
  } else {
    let exercises = await Exercise.find({ username: u.username });
    if (!exercises || exercises.length === 0) {
      res.send("Exercises not found");
    } else {
      const from = req.query.from;
      const to = req.query.to;
      const limit = req.query.limit;
      if (from && to) {
        exercises = exercises.filter((exercise) => {
          return (
            exercise.date >= new Date(from) && exercise.date <= new Date(to)
          );
        });
      }
      if (limit) {
        exercises = exercises.slice(0, limit);
      }
      exercises = exercises.map((exercise) => ({
        description: exercise.description,
        duration: exercise.duration,
        date: exercise.date.toDateString(),
      }));
      res.json({
        username: u.username,
        count: exercises.length,
        _id: u._id,
        log: exercises
      });
    }
  }
});
