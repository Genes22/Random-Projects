import speech_recognition as sr

r = sr.Recognizer()

audio = 'DATA_LOST.wav'

with sr.AudioFile(audio) as source:
    audio = r.record(source)
try:
    text = r.recognize_google(audio)
    print (text)
    print ('Done.!')

except Exception as e:
    print (e)
