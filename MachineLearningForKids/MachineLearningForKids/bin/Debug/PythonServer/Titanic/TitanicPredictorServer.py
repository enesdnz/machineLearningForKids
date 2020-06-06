import time
import urllib.request, json
import pandas as pd
import matplotlib.pyplot as plt
import pickle
from datetime import datetime
import sys

def LoadModel():
    filename ='C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Titanic\\gnb.sav'
    global loaded_model
    loaded_model = pickle.load(open(filename, 'rb'))
    #print("Prediction Model Loaded")
    #print("************************")
   
 


def Predict(predReq):
    Result=loaded_model.predict([predReq])
    #print("Prediction Result : ",Result)
    print(Result[0])
    #return Result;



LoadModel()
arry=sys.argv[1]
arry= eval(arry.split()[0])
#print(arry)
Predict(arry)


























