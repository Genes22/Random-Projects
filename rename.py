# #import nltk
# #nltk.download()
# #tokenizing - word.... sentence tokenizers
# #lexicon and corporas
# #corpora - body of text. ex. medical jounals, presidential speeches, English language
# #lexicon - words and their means

# #investor-speak.... regular english-speak
# #Investor speak 'bull' - trading meaning market information
# #english-speak 'bull' = big animal u don want it running @ u
# from nltk.tokenize import sent_tokenize, word_tokenize


# example = "some funny text"

# #print(sent_tokenize(example))
# #print(word_tokenize(example))

# for i in word_tokenize(example):
#     print(i)
import os
os.chdir("D:\\Music\\english")
files = os.listdir()
for file in files:
	if "1" and '0' in file:
		print('file contains numbers '+ file)
	else:
		print(file)
