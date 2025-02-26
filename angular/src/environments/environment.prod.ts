import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Ahmed Hamdi',
    logoUrl: '../assets/logo.png',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44332/',
    redirectUri: baseUrl,
    clientId: 'firstAbp_App',
    responseType: 'code',
    scope: 'offline_access firstAbp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'firstAbp',
    },
  },
} as Environment;
