const { questionerAmountAttrs, questioner } = require('../mechanism/questioner');
const { generateSourceCode } = require('../mechanism/generator');

module.exports = {
	name: 'clean',
	description: 'Delete',
	run: async (toolbox) => {

		const {
			parameters,
			template,
			print: { success, error, debug, warning},
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