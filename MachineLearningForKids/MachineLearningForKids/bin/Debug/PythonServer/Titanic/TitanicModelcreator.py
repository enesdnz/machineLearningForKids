import pandas as pd
import matplotlib.pyplot as plt


titanic_dataset=pd.read_csv("C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Titanic\\TitanicUserValues.csv",delimiter=r",");


#Gender kolonunu male-female 'nden 0 ve 1' e döndürüyoruz
titanic_dataset['Gender'] = titanic_dataset['Gender'].replace(['male','female'],[0,1])

#Embarked kolonunu  0,1 ve 2' e döndürüyoruz
titanic_dataset['Embarked'] = titanic_dataset['Embarked'].replace(['S','C','Q'],[0,1,2])

#print(titanic_dataset)



import seaborn as sns
sns.countplot(titanic_dataset['Survived'],label="Count")




#titanic_dataset.plot(kind='box', subplots=True, layout=(3,3),sharex=False,sharey=False,figsize=(8,8),title='Kolonlar')
#plt.show()



import pylab as pl
titanic_dataset.hist()





feature_names={'TicketClass','Gender','Age','SibSp','Parch','Fare','Embarked'}
X=titanic_dataset.drop('Survived', 1)
y=titanic_dataset['Survived']


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



"""
gamma='auto'
#Confusion matrix for knn classifer
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix

pred=gnb.predict(X_test)
print(confusion_matrix(y_test,pred))
print(classification_report(y_test,pred))

"""

#Save Models
import pickle
filename = 'C:\\ProjeYonetimiOrcunOzdil\\ProjeYonetimiOrcunOzdil\\bin\\Debug\\PythonServer\\Titanic\\gnb.sav'
pickle.dump(gnb, open(filename, 'wb'))








