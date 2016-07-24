﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkerLibrary
{
    public class AnswerBuilder
    {
        public string Answer(string lastMessage)
        {
            lastMessage = lastMessage.Trim();
            string inPossesion = "";
            string answer = "";
            string marker = "i have a ";
            if (lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                inPossesion = lastMessage.Substring(lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) + marker.Length).Split()[0];
                answer = "Tell me more about your " + inPossesion + "!";
            }
            marker = "i have no ";
            if (lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                inPossesion = lastMessage.Substring(lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) + marker.Length).Split()[0];
                answer = "Really? You have no " + inPossesion + "? Why?";
            }
            marker = "you have no ";
            if (lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                inPossesion = lastMessage.Substring(lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) + marker.Length).Split()[0];
                answer = "I probably have no " + inPossesion + " but I feel not bad because of this.";
            }
            marker = "you have a ";
            if (lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                inPossesion = lastMessage.Substring(lastMessage.IndexOf(marker, StringComparison.InvariantCultureIgnoreCase) + marker.Length).Split()[0];
                answer = "What about you? Do you have a " + inPossesion + "? Tell me more about it.";
            }
            if (string.IsNullOrEmpty(answer))
            {
                if (lastMessage.Contains("because") || lastMessage.Contains("Because"))
                {
                    answer = "Sometimes reasons have no credibility. You know?";
                }
                else
                if (lastMessage.Contains("you") || lastMessage.Contains("You"))
                {
                    answer = "Le us talk about something else :)";
                }
                else
                if (lastMessage.Contains("need") || lastMessage.Contains("Need"))
                {
                    answer = "Sometimes I need more space :P";
                }
                else
                if (lastMessage.Contains("feel ") || lastMessage.Contains("Feel "))
                {
                    answer = "Can you tell me something about that feeling?";
                }
                else
                if (lastMessage.Contains("yes") || lastMessage.Contains("Yes") || lastMessage.Contains("ok") || lastMessage.Contains("OK"))
                {
                    answer = "I like when you are optimistic. Tell me more!";
                }
                else
                if (lastMessage.StartsWith("no") || lastMessage.StartsWith("No"))
                {
                    answer = "Why are you pesimistic?";
                }
                else
                if (lastMessage.StartsWith("why") || lastMessage.StartsWith("Why"))
                {
                    answer = "Why are aware you are talking to a robot?";
                }
                else
                if (lastMessage.Contains("?") || lastMessage.Contains("?"))
                {
                    answer = "For some questions, we will never know the answer";
                }
                else
                    answer = "You are telling me that " + lastMessage.Replace("my ", "your ").Replace("you ", "Eliza ").Replace("I ", "you ") + "?";
            }
            return answer;
        }
    }
}