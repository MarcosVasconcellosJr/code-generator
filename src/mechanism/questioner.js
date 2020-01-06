const _QUESTIONS = require('./questions');

async function questionerAmountAttrs(prompt, error) {
    const response = await prompt.ask(_QUESTIONS.askAmountAttrs);

    if (!Number.isInteger(Number.parseInt(response.askAmountAttrs))) { 
        error('Please insert a number!'); 
        return -1; 
    }
    else return response.askAmountAttrs;
}

async function questioner(prompt, entityName, amountOfAttributtes, success, error) {
    const answers = [];

    const temp = answer = {
        askAttrVisibility: {},
        askAttrType: {},
        askAttrName: {},
        askAttrRequired: {},
        askAttrSearchParameterized: {},
        askAttrIsRelationObject: {},
        askAttrRelationType: {},
    };

	for(var i = 0; i < amountOfAttributtes ; i++) {
        answer = temp;

        do {
            answer.askAttrName = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrName));
            if (answer.askAttrName.attrName === '') {error("Attribute name must be specified"); }
        } while(answer.askAttrName == {} || answer.askAttrName.attrName === '');
        
        do {
            answer.askAttrType = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrType));
            if (answer.askAttrName.attrType === '') {error("Attribute type must be specified"); }
        } while(answer.askAttrType == {} || answer.askAttrName.attrType === '');

        do {
            answer.askAttrVisibility = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrVisibility));
            if (answer.askAttrVisibility.attrVisibility === '') {error("Attribute visibility must be specified"); }
        } while(answer.askAttrVisibility == {} || answer.askAttrVisibility.attrVisibility === '');
        
        do {
            answer.askAttrRequired = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrRequired));
            if (answer.askAttrRequired.attrRequired === '') {error("Attribute visibility must be specified"); }
        } while(answer.askAttrRequired == {} || answer.askAttrRequired.attrRequired === '');
        
        do {
            answer.askAttrSearchParameterized = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrSearchParameterized));
            if (answer.askAttrSearchParameterized.attrSearchParameterized === '') {error("Attribute search parameterized must be specified"); }
        } while(answer.askAttrSearchParameterized == {} || answer.askAttrSearchParameterized.attrSearchParameterized === '');
        
        do {
            answer.askAttrIsRelationObject = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrIsRelationObject));
            if (answer.askAttrIsRelationObject.attrIsRelationObject === '') {error("Attribute relation must be specified"); }
        } while(answer.askAttrIsRelationObject == {} || answer.askAttrIsRelationObject.attrIsRelationObject === '');
        
        if (answer.askAttrIsRelationObject.attrIsRelationObject === 'Yes'){
            do {
                _QUESTIONS.askAttrRelationType.message += ` ${entityName})`;
                answer.askAttrRelationType = Object.assign({}, await prompt.ask(_QUESTIONS.askAttrRelationType));
                if (answer.askAttrRelationType.attrRelationType === '') {error("Attribute relation type must be specified"); }
            } while(answer.askAttrRelationType == {} || answer.askAttrRelationType.attrRelationType === '');
        }
        console.log({ answer });
        answers.push(Object.assign({}, answer));
        success(`--------------- ${entityName} OK ------------------`);
    }

    return answers;
}

module.exports = {
    questionerAmountAttrs,
    questioner
}