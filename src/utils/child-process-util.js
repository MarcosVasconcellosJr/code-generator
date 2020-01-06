const { exec } = require('child_process');

function execute(commandOrProgram) {
    exec(commandOrProgram);
}

module.exports = {
    execute
}
