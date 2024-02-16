var express = require("express");
var app = express();
module.exports = app;

app.use('/timestamp', express.static("timestamp/public"));

app.get("/timestamp", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.get('/timestamp/hello', function(req, res) {
  res.json({ greeting: 'hello timestamp API' });
});

app.get("/timestamp/:date?", function (req, res){
  let date = req.params.date;
  let unix;
  let utc;
  if(date === undefined){
    unix = new Date().getTime();
    utc = new Date().toUTCString();
  }else if(date.match(/^\d+$/)){
    unix = parseInt(date);
    utc = new Date(parseInt(date)).toUTCString();
  }else{
    unix = new Date(date).getTime();
    utc = new Date(date).toUTCString();
  }
  if(utc === "Invalid Date"){
    res.json({error: "Invalid Date"});
  }else{
    res.json({unix: unix, utc: utc});
  }
});
