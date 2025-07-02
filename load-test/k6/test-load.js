import http from 'k6/http';
import { check, sleep } from 'k6';

export let options = {
  stages: [
    { duration: '10s', target: 100 },  // ramp-up
    { duration: '30s', target: 100 },  // carga constante
    { duration: '10s', target: 20 },   // ramp-down
  ],
};

export default function () {
  const urls = [
    'http://localhost:5000/text', // .NET
    'http://localhost:5000/time',
    'http://localhost:5001/text', // Node.js
    'http://localhost:5001/time',
  ];

  for (const url of urls) {
    let res = http.get(url);
    check(res, {
      'status é 200': (r) => r.status === 200,
    });
  }

  sleep(5);
}
