var express = require("express");
var app = express();
module.exports = app;

app.use('/express', express.static("express/public"));

app.get("/express", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.get('/express/hello', function(req, res) {
  res.json({ greeting: 'hello express API' });
});

bodyParser = require("body-parser");

app.use('/express/json', (req, res, next) =>{
  console.log(`${req.method} ${req.path} - ${req.ip}`);  
  next();  
});


app.get('/express/now',(req, res, next) =>{
  req.time = new Date().toString();  
  next();
}, (req, res) => res.json({time: req.time}));


app.get('/express/:word/echo', (req, res, next) => res.json({echo: req.params.word}));


app.get('/express/name', (req, res, next) => res.json({name: `${req.query.first} ${req.query.last}`}));


app.use('/express', bodyParser.urlencoded({extended: false}));


app.post(
  "/express/name",  
  bodyParser.urlencoded({extended: false}),
  (req, res, next) => res.json({name: `${req.body.first} ${req.body.last}`})
);



