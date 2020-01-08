const { askReallyClean } = require('../manager/questions/clean');

module.exports = {
	name: 'clean',
	description: 'Deletes an old folder of code generated based on current directory',
	run: async (toolbox) => {
		var answer = {};

		const {
			filesystem,
			print: { success, error, warning},
			prompt
		} = toolbox;

		//Tranfer this to questioner
		answer = Object.assign({}, await prompt.ask(askReallyClean));

		if (answer.reallyClean === 'Yes') {
			try {
				if (filesystem.list('./').includes('generated-code')) {
					filesystem.remove('./generated-code');
					success("Folder successfully removed");
				} else {
					error("Did not could be remove (generated-code) dir, because it does not exist :(");
					error("Please, verify your current dir!");
				}
			} catch (error) {
				error("An error ocurred: " + error)
			}
		}
	}
}