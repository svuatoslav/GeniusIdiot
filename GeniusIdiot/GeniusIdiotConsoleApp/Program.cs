using GeniusIdiotConsoleApp;
using GeniusIdiot.Common;

FileLogger _ = new(Path.Combine(StoragePath.ProjectPath, StoragePath.PathLogs));

var message = new MessageManager();

Question.GetQuestionsFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
User.GetUsersFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));

TestApp test = new(Question.Questions, Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage)); // Data/XML/XMLFiles/DATA.xml

test.Testing();

Editor.EditTests(test, message, Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
