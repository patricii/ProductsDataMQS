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

- Se desejar inserir os dados permanentemente, utilizar a opção "Insert To DB"
 e os dados atualizados serão inseridos na table "MQSDailyData";

- Na opção "Compare Test Time" é possivel comparar as mudanças de AvgTestTime
da Table MQSDailyDataTemp e MQSDailyData.

- No campo "Filter Value" é possivel filtrar as alterações de AvgTestTime por
diferença em segundos "s" dos dados anteriores (MQSDailyData) os novos dados
 puxados (MQSDailyDataTemp);

- No campo "Filter Count" serão mostradas as quantidades de Testes com 
diferença de AvgTestTime maiores do que o valor solicitado em "Filter Value"

- No campo "Total Count" serão mostradas as quantidades totais de Testes
com diferença entre os dados da Table "MQSDailyData" com a table 
"MQSDailyDataTemp";

****************************************************************************
****************************************************************************
**************************Developed by A. Patricio**************************
****************************************************************************
****************************************************************************