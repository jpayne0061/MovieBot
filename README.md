# MovieBot
chat with a bot that is programmed to answer questions that appeared in movie scripts


#ATTENTION: I am still working on how to get the database to work, these instructions may not work
#How can I run this app?
1. You will need visual studio
2. Clone this repo
3. Download these files from dropbox(it's over the size limit for github) 
https://www.dropbox.com/s/71kb7ra14c42hyq/DBForQuestions.mdf?dl=0
https://www.dropbox.com/s/jasr9p81gqzcr3y/DBForQuestions_log.ldf?dl=0
(you do not need to create an account, once you get to the bottom click "no thanks, continue")
4. Place these files in your App_Data folder
5. Run the app!


#How was this made?

This project was made by scraping the The Internet Movie Script Database.Using python, 
I scraped any line from a script that ended with "?" and the following line as well. These two items would 
be stored as a json object representing a question and answer pair.

This json objects were then converted into c# objects and stored in an sql db. Using an api, 
a user can "chat" with the bot by asking questions. If the question matches one found in a movie,
the bot will respond with the answer.
