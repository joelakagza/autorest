'use strict';

var util = require('util');

var models = require('./index');

/**
 * @class
 * Initializes a new instance of the SubProductProperties class.
 * @constructor
 */
function SubProductProperties() { }

/**
 * Validate the payload against the SubProductProperties schema
 *
 * @param {JSON} payload
 *
 */
SubProductProperties.prototype.validate = function (payload) {
  if (!payload) {
    throw new Error('SubProductProperties cannot be null.');
  }
  if (payload['provisioningStateValues'] !== null && payload['provisioningStateValues'] !== undefined && typeof payload['provisioningStateValues'] !== 'string') {
    throw new Error('payload["provisioningStateValues"] must be of type string.');
  }

};

/**
 * Deserialize the instance to SubProductProperties schema
 *
 * @param {JSON} instance
 *
 */
SubProductProperties.prototype.deserialize = function (instance) {
  return instance;
};

module.exports = new SubProductProperties();