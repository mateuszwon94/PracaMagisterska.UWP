using System;
using System.Collections.Generic;
using System.Linq;

namespace PracaMagisterska.EventArgs {
	public class NavigatedToSourceCodePageEventArgs : System.EventArgs {
		public NavigatedToSourceCodePageEventArgs(int lessonNumber) => LessonNumber = lessonNumber;

		public int LessonNumber { get; private set; }

	}
}