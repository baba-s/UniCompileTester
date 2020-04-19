using NUnit.Framework;
using System.IO;
using UnityEditor;
using UnityEditor.Build.Player;

namespace UniCompileTester
{
	internal sealed class CompileTester
	{
		private const string OUTPUT_FOLDER = "Temp/CompileChecker";

		[Test]
		public void CheckiOS()
		{
			Check( BuildTarget.iOS );
		}

		[Test]
		public void CheckAndroid()
		{
			Check( BuildTarget.Android );
		}

		[Test]
		public void CheckWebGL()
		{
			Check( BuildTarget.WebGL );
		}

		private static void Check( BuildTarget target )
		{
			var group = BuildPipeline.GetBuildTargetGroup( target );

			var input = new ScriptCompilationSettings
			{
				target = target,
				group  = group,
			};

			PlayerBuildInterface.CompilePlayerScripts( input, OUTPUT_FOLDER );

			if ( Directory.Exists( OUTPUT_FOLDER ) )
			{
				Directory.Delete( OUTPUT_FOLDER, true );
			}
		}
	}
}