using System;
namespace Hangman
{
    // Custom exception class for handling wrong inputs
    internal class WrongInputException: ApplicationException 
	{
		private string _msg;

		public WrongInputException()
		{
			_msg = "Enter one letter!";
		}

        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}

