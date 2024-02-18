const express = require("express");
const app = express();
const cors = require("cors");
const router = express.Router();
const headerparserApp = require('./headerparser/index');
const urlshortenerApp = require('./urlshortener/index');
const filemetadataApp = require('./filemetadata/index');
const expressApp = require('./express/index');
const timestampApp = require('./timestamp/index');
const contactApp = require('./contact/index');

router.use(headerparserApp,urlshortenerApp,filemetadataApp,expressApp,timestampApp,contactApp);

app.use(
  "/api", 
  cors({ optionsSuccessStatus: 200 }),
  router
);

var listener = app.listen(process.env.PORT || 3000, function () {
  console.log("Your app is listening on port " + listener.address().port);
});