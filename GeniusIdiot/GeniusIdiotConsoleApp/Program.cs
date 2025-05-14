using GeniusIdiotConsoleApp;
using GeniusIdiot.Common;

FileLogger _ = new(Path.Combine(StoragePath.ProjectPath, "Logs.txt"));

var message = new MessageManager();

Question.GetQuestionsFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
User.GetUsersFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));

TestApp test = new(Question.Questions, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage)); // Data/XML/XMLFiles/DATA.xml

test.Testing();

Editor.EditTests(test, message, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));