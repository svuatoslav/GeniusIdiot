using GeniusIdiotConsoleApp;
using GeniusIdiot.Common;

FileLogger.Path = StoragePath.PathLogs;

var message = new MessageManager();

Question.GetQuestionsFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
User.GetUsersFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));

TestApp test = new(Question.Questions, Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage)); // Data/XML/XMLFiles/DATA.xml

test.Testing();

Editor.EditTests(message, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));