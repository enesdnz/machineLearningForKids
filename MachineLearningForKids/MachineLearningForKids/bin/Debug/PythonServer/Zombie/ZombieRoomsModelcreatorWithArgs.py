import pandas as pd
import matplotlib.pyplot as plt
import sys

dataFileName="C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Zombie\\RoomData.csv"
modelFileName="C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Zombie\\gnb_zombie.sav"

def CreateModel(arguments):
    zombieRoom_dataset=pd.read_csv(dataFileName,delimiter=r",")

    feature_names=['v1','v2','v3','v4','v5','v6','v7','v8','v9','v10','v11','v12','safe']
    X=zombieRoom_dataset.drop(feature_names[12], 1)
    for i in range (12):
        if arguments[i]=='0':
            X=X.drop(feature_names[i], 1) 
            #print(X)


       
    y=zombieRoom_dataset[feature_names[12]]

    #print(X)

    
    from sklearn.model_selection import train_test_split
    X_train,X_test,y_train,y_test = train_test_split(X,y,random_state=0)
    from sklearn.preprocessing import MinMaxScaler
    scaler=MinMaxScaler();
    X_train=scaler.fit_transform(X_train)
    X_test=scaler.fit_transform(X_test)

    
    #NaiveBayes
    ################################
    from sklearn.naive_bayes import GaussianNB
    gnb=GaussianNB()
    gnb.fit(X_train,y_train)
    print('Accuracy of GaussianNB Classifier on training set: {:.2F}'
          .format(gnb.score(X_train,y_train)))
    print('Accuracy of GaussianNB Tree Classifier on test set: {:.2F}'
          .format(gnb.score(X_test,y_test)))
    #NaiveBayes 
    
    #Save Models
    import pickle
    pickle.dump(gnb, open(modelFileName, 'wb'))

    
program_name = sys.argv[0]
arguments = sys.argv[1:]
count = len(arguments)

if count==1:
    arguments = (str)(arguments[0])
    CreateModel(arguments)      
else:
    print("no arguments")










