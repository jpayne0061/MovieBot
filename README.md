# MovieBot
chat with a bot that is programmed to answer questions that appeared in movie scripts

#How can I run this app?
1. You will need visual studio
2. Clone this repo
3. Download this file from dropbox(it's over the size limit for github) https://www.dropbox.com/s/71kb7ra14c42hyq/DBForQuestions.mdf?dl=0
4. Place this file in your App_Data folder
5. Run the app!


#How was this made?

This project was made by scraping the The Internet Movie Script Database.Using python, 
I scraped any line from a script that ended with "?" and the following line as well. These two items would 
be stored as a json object representing a question and answer pair.

This json objects were then converted into c# objects and stored in an sql db. Using an api, 
a user can "chat" with the bot by asking questions. If the question matches one found in a movie,
the bot will respond with the answer.
