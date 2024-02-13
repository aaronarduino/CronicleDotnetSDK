using System;
using System.Text.Json;
using CronicleDotnetSDK.Models;

namespace CronicleDotnetSDK
{
	public abstract class CronicleJob
	{
		private bool _jobStatusSent { get; set; } = false;
		private bool _failIfNoJobStatusSent { get; set; }

		public CronicleJob(bool debugMode = false, bool failIfNoJobStatusSent = false)
		{
			_failIfNoJobStatusSent = failIfNoJobStatusSent;
		}

		private Job? GetJobDescription()
		{
            string input = Console.ReadLine() ?? string.Empty;

            return JsonSerializer.Deserialize<Job>(input);
        }

		public void SendJobStatus(bool success, int code = 0)
		{
			JobStatus jobStatus = new JobStatus()
			{
				Complete = success ? 1 : 0,
				Code = code,
			};
			string output = JsonSerializer.Serialize(jobStatus);
			Console.WriteLine(output);
			_jobStatusSent = jobStatus.Complete == 1;
        }

		public void SendTable(string title, List<List<string>> data)
		{
			Table table = new Table()
			{
				Title = title,
				Header = data[0],
				Rows = data.Skip(1).ToList(),
				Caption = "This is a caption",
			};
			TableContainer tableContainer = new TableContainer(table);
			string output = JsonSerializer.Serialize(tableContainer);
			Console.WriteLine(output);
		}

		public abstract void JobWork(Job jobDescription);

		public void Run()
		{
			Job? jobDescription = GetJobDescription();
			if (jobDescription != null)
			{
				JobWork(jobDescription);
			}
			else
			{
				SendJobStatus(false, code: 1);
			}

			if (_failIfNoJobStatusSent && !_jobStatusSent)
			{
				SendJobStatus(false, code: 1);
			}
			else
			{
				SendJobStatus(true);
			}
		}

		public void RunDebugMode(Job jobDescription)
		{
			JobWork(jobDescription);
		}
	}
}

