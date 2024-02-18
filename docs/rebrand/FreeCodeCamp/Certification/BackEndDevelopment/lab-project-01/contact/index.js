const express = require("express");
const app = express();
module.exports = app;

app.use('/contact', express.static("contact/public"));

app.get("/contact", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

bodyParser = require("body-parser");

app.use('/contact', bodyParser.urlencoded({extended: false}));


app.post(
  "/contact/skills",  
  bodyParser.urlencoded({extended: false}),
  (req, res, next) => {
    /*
    const contact = new ContactSkills(req.body);

    contact.save((err, data) => {
      if (err) {
        done(err);
      } else {
        done(null, data);
      }
    });
*/
console.log(req.body.email);
    return res.json({ok: true})
  }
);

router.post("/mongoose-model", function (req, res, next) {
  // try to create a new instance based on their model
  // verify it's correctly defined in some way
  let p;
  p = new Person(req.body);
  res.json(p);
});

