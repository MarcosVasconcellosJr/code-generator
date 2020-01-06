const askAmountAttrs = {
    type: 'input',
    name: 'askAmountAttrs',
    message: 'How many attributes does your entity have?'
}

const askAttrName = {
    type: 'input',
    name: 'attrName', 
    message: 'Which is the name of the atributte?'
}

const askAttrRequired = { 
    type: 'select',
    name: 'attrRequired',
    message: 'This parameter is required?',
    choices: [ 'Yes', 'No' ],
}

const askAttrType = {
    type: 'select',
    name: 'entityType',
    message: 'What type are you wearing?',
    choices: [ 
        'String',
        'Int32',
        'Double',
        'Boolean',
        'DateTimeOffset',
        'DateTime',
        'Enumerator',
        'sbyte', 
        'byte', 
        'short', 
        'ushort', 
        'int', 
        'uint', 
        'long', 
        'ulong', 
        'char', 
        'float', 
        'decimal' 
    ],
}

const askAttrVisibility = {
    type: 'select',
    name: 'attrVisibility',
    message: 'What is the visibility of the attribute?',
    choices: [ 'public', 'private', 'protected' ],
}

const askAttrSearchParameterized = {
    type: 'select',
    name: 'attrSearchParameterized',
    message: 'Add to the search parameter?',
    choices: [ 'No', 'Yes' ],
}

const askAttrIsRelationObject = { 
    type: 'select',
    name: 'attrIsRelationObject',
    message: 'This parameter is the Relation Object?',
    choices: [ 'Yes', 'No' ],
}

const askAttrRelationType = {
    type: 'select',
    name: 'attrRelationType',
    message: 'Wich is the Relation Type? (Left cardinality represents your entity',
    choices: [ '1:N', 'N:N', '1:1' ],
}

module.exports = {
    askAmountAttrs,
    askAttrName,
    askAttrRequired,
    askAttrType,
    askAttrVisibility,
    askAttrSearchParameterized,
    askAttrIsRelationObject,
    askAttrRelationType
}
