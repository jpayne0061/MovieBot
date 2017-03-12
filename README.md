# MovieBot
chat with a bot that is programmed to answer questions that appeared in movie scripts


#How was this made?

This project was made by scraping the The Internet Movie Script Database.Using python, 
I scraped any line from a script that ended with "?" and the following line as well. These two items would 
be stored as a json object representing a question and answer pair.

This json objects were then converted into c# objects and stored in an sql db. Using an api, 
a user can "chat" with the bot by asking questions. If the question matches one found in a movie,
the bot will respond with the answer.
