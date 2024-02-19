const express = require("express");
const app = express();
const multer  = require('multer')
const upload = multer({ dest: 'uploads/' })

module.exports = app;

app.use('/contact', express.static("contact/public"));

app.get("/contact", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.post(
  "/contact/skills",  
  upload.none(),
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
    return res.json({v:1, name: `${req.body.email} ${req.body.msg}`})
    //return res.json({ok: true})
  }
);

