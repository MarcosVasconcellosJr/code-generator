const askReallyClean = { 
    type: 'select',
    name: 'reallyClean',
    message: 'Do you really want excludes (generated-code) folder permanently?',
    choices: [ 'No', 'Yes' ],
}

module.exports = {
    askReallyClean,
}