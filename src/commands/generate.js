const { questionerAmountAttrs, questioner } = require('../manager/questioners/questioner');
const { generateSourceCode } = require('../manager/generators/generator');

module.exports = {
	name: 'generate',
	description: 'Create an (service, repository, searchParameter and DTOs) based on entity has passed into CLI',
	run: async toolbox => {

		const {
			parameters,
			template,
			print: { success, error },
			prompt
		} = toolbox;

		const entityName = parameters.first;

		if(!entityName) { error('Entity name must be specified'); return }

		// Ask to obtain number of questions547u
		const amountOfAttributtes = await questionerAmountAttrs(prompt, error);
		if (amountOfAttributtes == -1) return;

		const subsequentAnswers = await questioner(prompt, entityName, amountOfAttributtes, success, error);

		const attributtes = [];
		subsequentAnswers.forEach(element => {
			attributtes.push(Object.assign({}, element));
		});
		
		await generateSourceCode(template, { entityName, success, attributtes } );
  }
}