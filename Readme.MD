****************************************************************************
****************************************************************************
*******************************ProductDataMQS*******************************
****************************************************************************
****************************************************************************
- A Aplicação deve rodar no diretório C:\ProductDataMQS;

- A Aplicação contempla um DataBase com duas tabelas MQSDailyData e 
MQSDailyDataTemp;

- A opção "MQS UPDATE" se conecta com o MQS e trás dados em tempo real dos
periodos solicitados em poucos segundos;

- Após A busca dos dados na opção "MQS UPDATE" as informações do MQS serão 
alocadas na table "MQSDailyDataTemp";

- Se desejar inserir os dados permanentemente, primeiramente será necessário 
o "Login" na aplicação para registro de alterações, posteriormente utilizar 
a opção "Insert To DB" e os dados atualizados serão inseridos na table 
"MQSDailyData";

- Na opção "Compare Test Time" é possivel comparar as mudanças de AvgTestTime
da Table MQSDailyDataTemp e MQSDailyData.

- No campo "Filter Value" é possivel filtrar as alterações de AvgTestTime por
diferença em segundos "s" dos dados anteriores (MQSDailyData) os novos dados
 puxados (MQSDailyDataTemp) 
Obs:Valores de delta de TT >= Filter Value serão listados;

- No campo "Filter Count" serão mostradas as quantidades de Testes com 
diferença de AvgTestTime maiores do que o valor solicitado em "Filter Value"

- Se desejar incluir manualmente algum novo produto ou qualquer alteração,
utilizar as opções abaixo do botão "Login", após qualquer alteração será 
necessário clicar no botão "Save" para que as mudanças sejam aplicadas. 


****************************************************************************
****************************************************************************
**************************Developed by A. Patricio**************************
****************************************************************************
****************************************************************************