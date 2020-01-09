const run = require('../runners/generate');

module.exports = {
	name: 'generate',
	description: 'Create an (service, repository, migration and controller) based on entity has passed into CLI',
	run,
}