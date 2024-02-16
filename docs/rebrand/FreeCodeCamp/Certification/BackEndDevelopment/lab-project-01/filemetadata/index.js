
var express = require("express");
var app = express();
const multer  = require('multer')
const upload = multer({ dest: 'uploads/' })
module.exports = app;

app.use('/filemetadata', express.static("filemetadata/public"));

app.get("/filemetadata", function (req, res) {
  res.sendFile(__dirname + "/views/index.html");
});

app.get('/filemetadata/hello', function(req, res) {
  res.json({ greeting: 'hello filemetadata API' });
});

app.post('/filemetadata/fileanalyse', upload.single('upfile'), function (req, res) {
  res.json({
    name: req.file.originalname,
    type: req.file.mimetype,
    size: req.file.size
  })
});
