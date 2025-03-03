using GeniusIdiotConsoleApp;
using GeniusIdiotConsoleApp.Data;
using GeniusIdiotConsoleApp.Data.XML;

DataManager dataManager = new DataManager();

XMLManager.WriteXML(dataManager.Questions);

//Questionnaire.FormFilling();