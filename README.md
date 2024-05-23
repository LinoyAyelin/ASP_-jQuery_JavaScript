In this project, I have built the beginnings of a gaming website that includes 5 ASPX pages and one HTML page:

- RegisterLogin.aspx: This page allows a user to register or log in.
- Games.aspx: This page displays a list of games.
- TicTac.aspx: This page displays the Tic-Tac-Toe game board.
- GameOver.aspx: This page displays the winner at the end of the game.
- Error.aspx: This page displays various errors.
- topPlayers.html: This page displays a table of players and their scores.

In all the ASPX pages, all the logic including validation, event handling, page redirection, and game implementation is performed on the server-side using C# code.

# When the user clicks the "Show Players" button, it navigates to the topPlayers.html page:
On this page, I have implemented the following JavaScript (JS) events:
- Clicking the "Show Player List" button: Adds (appendChild) a new table with a random size and a list of players, where the number of goals is a random number between 1 and 120.
  Clicking the button again removes the table from the page (removeChild).
- Clicking it once more will display the table again, and so on.
- Clicking the "Find Best Player" button: Scans the dynamically created table and highlights the best player with the maximum number of goals.

# When the user chooses the "Registered User" button or opts to register as a new user:
Since we do not yet have a database to compare against existing users, we will allow "Registered User Login" only if the string in "Username" and the string in "Password" differ only in case (case-insensitive match).
Since we do not yet have a database to register new users, we will allow "New User Registration" only if:
- All fields are not empty.
- The email field contains the character '@'.
- The "Password" field exactly matches the "Repeat Password" field.

If you need additional details, feel free to ask!
