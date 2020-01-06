function checkSearchParameter(attributte) {
  return attributte.attrSearchParameterized === 'Yes'
}

async function generateSourceCode(template, props) {
  /*************************    API     ********************/
  /*********************** Controller OK *******************/

  await template.generate({
    template: 'Api/Controller.cs.ejs',
    target: `./src/generated-code/Api/Controllers/Entity/${props.entityName}Controller.cs`,
    props
  })
  props.success(`Api: Generated ${props.entityName}Controller.cs`)

  /************************* PublicDTO OK *********************/

  await template.generate({
    template: 'Api/DTO/PublicDTO.cs.ejs',
    target: `./src/generated-code/Api/DTO/${props.entityName}/Public${props.entityName}DTO.cs`,
    props
  })
  props.success(`Api: Generated Public${props.entityName}DTO.cs`)

  /************************* PrivateDTO OK ********************/

  await template.generate({
    template: 'Api/DTO/PrivateDTO.cs.ejs',
    target: `./src/generated-code/Api/DTO/${props.entityName}/Private${props.entityName}DTO.cs`,
    props
  })
  props.success(`Api: Generated Private${props.entityName}DTO.cs`)

  /************************ SelectiveDTO OK *******************/

  await template.generate({
    template: 'Api/DTO/SelectiveDTO.cs.ejs',
    target: `./src/generated-code/Api/DTO/${props.entityName}/Selective${props.entityName}DTO.cs`,
    props
  })
  props.success(`Api: Generated Selective${props.entityName}DTO.cs`)

  /*************************  DOMAIN    ********************/
  /************************* Service OK ********************/

  await template.generate({
    template: 'Domain/Service.cs.ejs',
    target: `./src/generated-code/Domain/Services/${props.entityName}Service/${props.entityName}Service.cs`,
    props
  })
  props.success(`Domain: Generated ${props.entityName}Service.cs`)

  /************************* Model OK ********************/

  await template.generate({
    template: 'Domain/Model.cs.ejs',
    target: `./src/generated-code/Domain/Model/${props.entityName}Model.cs`,
    props
  })
  props.success(`Domain: Generated ${props.entityName}Model.cs`)

  /************************* Repository OK ********************/

  await template.generate({
    template: 'Domain/Repository.cs.ejs',
    target: `./src/generated-code/Domain/Repository/I${props.entityName}Repository.cs`,
    props
  })
  props.success(`Domain: Generated ${props.entityName}Repository.cs`)

  /************************* SearchParameter OK ********************/

  const searchAttributtes = props.attributtes.filter(checkSearchParameter)
  props.searchAttributtes = searchAttributtes;

  await template.generate({
    template: 'Domain/SearchParameter.cs.ejs',
    target: `./src/generated-code/Domain/SearchParameter/${props.entityName}SearchParameter.cs`,
    props
  })
  props.success(`Domain: Generated ${props.entityName}SearchParameter.cs`)

  /*************************    REPOSITORY    **********************/
  /*************************   Repository OK    ********************/

  await template.generate({
    template: 'Repository/Repository.cs.ejs',
    target: `./src/generated-code/Repository/Repository/${props.entityName}Repository.cs`,
    props
  })
  props.success(`Repository: Generated ${props.entityName}Repository.cs`)

  /*****************************************************************/
}

module.exports = {
  generateSourceCode
}