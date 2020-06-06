import time
import urllib.request, json
import pandas as pd
import matplotlib.pyplot as plt
import pickle
from datetime import datetime
import sys


modelFileName="C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Zombie\\gnb_zombie.sav"





def LoadModel():    
    global loaded_model
    loaded_model = pickle.load(open(modelFileName, 'rb'))
    #print("Prediction Model Loaded")
    #print("************************")
    time.sleep(2)
 


def Predict(predReq):
    #print(predReq)
    Result=loaded_model.predict([predReq])
    Result=(str)(Result[0])
    print(Result)


LoadModel()


program_name = sys.argv[0]
arguments = sys.argv[1:]
count = len(arguments)
if count==1:    
    arguments = (str)(arguments[0])
    arguments=arguments.split(',')
    arguments=list(map(float, arguments))
    Predict(arguments)
    
else:
    print("no arguments")























