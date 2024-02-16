// index.js
// where your node app starts

// init project
var express = require("express");
var app = express();
module.exports = app;

// http://expressjs.com/en/starter/static-files.html
app.use('/headerparser', express.static("headerparser/public"));

// http://expressjs.com/en/starter/basic-routing.html
app.get("/headerparser", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

// your first API endpoint...
app.get("/headerparser/hello", function (req, res) {
  res.json({ greeting: "hello headerparser API" });
});

app.get("/headerparser/whoami", (req, res) => {
  res.json({
    ipaddress: req.headers["x-forwarded-for"],
    language: req.headers["accept-language"],
    software: req.headers["user-agent"],
  });
});
