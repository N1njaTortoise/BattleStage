﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BattleStage.MenuInput
{
    static class Utilities
    {
        public static void ClearErrorLines(int linesToClear)
        {
            int currentLine = Console.CursorTop - linesToClear;

            for (int i = 1; i <= linesToClear; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, currentLine);
        }

        public static void InputError(string text, ConsoleColor color)
        {
            Console.Beep();
            ColorWriteLines(text, color);
        }

        public static void ColorWriteLines(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void FadeText(string text, bool fadeIn)
        {
            int timeBetweenFades = 60;

            if (fadeIn == true)
            {
                ColorWriteLines(text, ConsoleColor.Black);
                Thread.Sleep(timeBetweenFades);
                Console.Clear();

                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.Gray);
                Thread.Sleep(timeBetweenFades);
                Console.Clear();

                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.White);
                Thread.Sleep(timeBetweenFades);
                Console.Clear();

                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.Green);
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.White);

                Thread.Sleep(timeBetweenFades);
                Console.Clear();

                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.Gray);
                Thread.Sleep(timeBetweenFades);
                Console.Clear();

                MenuQueries.MenuSubMenu();

                ColorWriteLines(text, ConsoleColor.Black);
                Console.Clear();
                Console.ResetColor();

                MenuQueries.MenuSubMenu();
            }
        }

        public static void AnimationBattle(string[] animationClip)
        {
            int delayBetweenAnimationCycles = 250;

            for (int i = 0; i < animationClip.Length; i++)
            {
                ColorWriteLines(animationClip[i], ConsoleColor.Gray);
                Thread.Sleep(delayBetweenAnimationCycles);
                MenuQueries.ConsoleClearResetMenu();
            }

            for (int i = animationClip.Length - 1; i >= 0; i--)
            {
                ColorWriteLines(animationClip[i], ConsoleColor.Gray);
                Thread.Sleep(delayBetweenAnimationCycles);
                MenuQueries.ConsoleClearResetMenu();
            }
        }
    }
}
