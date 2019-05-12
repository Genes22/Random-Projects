#import nltk
#nltk.download()
#tokenizing - word.... sentence tokenizers
#lexicon and corporas
#corpora - body of text. ex. medical jounals, presidential speeches, English language
#lexicon - words and their means

#investor-speak.... regular english-speak


#Investor speak 'bull' - someone who is positive about the market
#english-speak 'bull' = scary animal u don't want running @ u
from nltk.tokenize import sent_tokenize, word_tokenize


example = "Hello Mr.Samwel, how are you doing today? The weather is great and python is awesome. the sky is pinkish-blue you should not eat card board"

#print(sent_tokenize(example))
#print(word_tokenize(example))

for i in word_tokenize(example):
    print(i)
