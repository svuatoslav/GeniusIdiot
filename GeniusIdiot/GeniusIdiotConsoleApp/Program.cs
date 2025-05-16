using GeniusIdiotConsoleApp;
using GeniusIdiot.Common;

FileLogger.Path = StoragePath.PathLogs;

var message = new MessageManager();

Question.GetQuestionsFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
User.GetUsersFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));

TestApp test = new(Question.Questions, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage)); // Data/XML/XMLFiles/DATA.xml

test.Testing();

Editor.EditTests(message, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));