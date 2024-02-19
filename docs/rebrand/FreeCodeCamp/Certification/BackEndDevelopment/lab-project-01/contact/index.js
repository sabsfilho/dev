const express = require("express");
const app = express();
const multer  = require('multer')
const upload = multer({ dest: 'uploads/' })

module.exports = app;

app.use('/contact', express.static("contact/public"));

app.get("/contact", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

const mongoose = require("mongoose");

mongoose.connect(process.env.MONGO_URI, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});

const Schema = mongoose.Schema;

const contactSkillSchema = new Schema({
  email: String,
  ip: String,
  msg: String
});

const ContactSkill = mongoose.model("ContactSkill", contactSkillSchema);

app.get('/contact/skills', async (req, res) =>{
  const xs = await ContactSkill.find({});
  res.send(xs);  
});

app.post(
  "/contact/skills",  
  upload.none(),
  async (req, res, next) => {
    const contact = new ContactSkill({
      email: req.body.email,
      ip: req.headers["x-forwarded-for"],
      msg: req.body.msg
    });

    await contact.save();

    return res.json({ok: true})
  }
);

