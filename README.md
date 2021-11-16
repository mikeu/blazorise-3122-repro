# Blazorise #3122 reproduction

This is a sample application that reproduces [Megabit/Blazorise#3122](https://github.com/Megabit/Blazorise/issues/3122).

Running it and then visiting `https://localhost:5001/subdir` shows the standard Blazor error message, and logs an error
to the browser console. Downgrading Blazorise to v0.9.4.8 or earlier resolves the error, and the tooltip works as expected.