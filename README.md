Counting Press
==============

A tiny utility that will run in background and count how many key you pressed on the keyboard.

The idea is just for relaxing only, because sometimes I want to know that exactly the number of pressed key on the keyboard in my daily works. You know, i'm working everyday with my computer, so i want to have a little summary for what i've performed during working time. So it's a time-wasting (or maybe useless) project, but it's fun.

This tiny project is written in some couple of minutes, so all the features are just very simple. The most time-consumption work is design the interface for it, not the main code for hooking keyboard and counting key pressed.

I use C# because it is very fast when designing interface. Project was created in Visual Studio 2015 Community, and .NET 2.0 (for stablity on Old machine when run).

How it works
------------

Using P/Invoke API to set Global Hook for Keyboard, receive Windows Message when key pressed/released, and increase the counter. That's all.

Enjoy the counting, and except bugs, if any.