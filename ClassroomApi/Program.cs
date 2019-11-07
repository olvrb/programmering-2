using Google.Apis.Auth.OAuth2;
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassroomApi {
    class Program {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/classroom.googleapis.com-dotnet-quickstart.json
         List<string> Scopes = new List<string> { ClassroomService.Scope.ClassroomCoursesReadonly };
        
        static string ApplicationName = "Classroom API .NET Quickstart";

        static void Main(string[] args) => new Program().Run();

        private void Run() {
            Scopes.AddRange(typeof(ClassroomService.Scope).GetProperties().Select(x => (string)x.GetValue(this, null)));
            Console.WriteLine(Scopes.Aggregate((x,y) => $"{x}, {y}"));
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read)) {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Classroom API service.
            var service = new ClassroomService(new BaseClientService.Initializer() {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            CoursesResource.ListRequest request = service.Courses.List();
            request.PageSize = 10;

            // List courses.
            ListCoursesResponse response = request.Execute();
            Console.WriteLine("Courses:");
            if (response.Courses != null && response.Courses.Count > 0) {
                foreach (var course in response.Courses) {
                    Console.WriteLine("{0} ({1})", course.Name, course.Id);
                }
            }
            else {
                Console.WriteLine("No courses found.");
            }

            Console.Read();
        }
    }
}