const express = require('express');
const apicache = require('apicache');
const client = require('prom-client');

const app = express();
const cache = apicache.middleware;

const collectDefaultMetrics = client.collectDefaultMetrics;
collectDefaultMetrics();

app.get('/metrics', async (req, res) => {
  res.set('Content-Type', client.register.contentType);
  res.end(await client.register.metrics());
});

app.get('/text', cache('1 minute'), (req, res) => {
  res.send('Eu sou a aplicação Node.js');
});

app.get('/time', cache('1 minute'), (req, res) => {
  res.send(new Date().toISOString());
});

const port = process.env.PORT || 3000;
app.listen(port, () => {
  console.log(`Node API running on port ${port}`);
});
