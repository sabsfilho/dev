
var express = require("express");
var app = express();
module.exports = app;

app.use('/urlshortener', express.static("urlshortener/public"));

app.get("/urlshortener", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.get('/urlshortener/hello', function(req, res) {
  res.json({ greeting: 'hello urlshortener API' });
});

const bodyParser = require('body-parser'),
  dns = require('dns'),
  url = require('url'),
  urlMap = new Map();

app.use(bodyParser.urlencoded({ extended: false }));

app.post('/urlshortener/shorturl', (req, res) =>{
  const orig = req.body.url,
    parsed = url.parse(orig);
  if(!parsed.hostname){
    return res.json({error: 'invalid url'});
  }
  dns.lookup(parsed.hostname, (err) => {
    if(err){
      return res.json({error: 'invalid url'});
    }
    const short = urlMap.size + 1; // int key
    urlMap.set(short, orig);
    res.json({
      original_url: orig, 
      short_url: short
    });
  });
});
app.get('/urlshortener/shorturl/:shortUrl', (req, res) =>{
  const short = parseInt(req.params.shortUrl);
  if(isNaN(short)){
    return res.json({error: 'invalid url'});
  }
  const orig = urlMap.get(short);
  if(!orig){
    return res.json({error: 'invalid url'});
  }
  res.redirect(orig);
});
