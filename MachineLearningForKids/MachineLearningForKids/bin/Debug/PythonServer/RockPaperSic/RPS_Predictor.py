import numpy as np
import cv2
from matplotlib import pyplot as plt
import numpy as np
from PIL import Image
from keras.preprocessing import image
import pickle
import cv2
from pathlib import Path
import os



img = cv2.imread('C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\dataset\\single_prediction\\ImageToPredict.jpg')
mask = np.zeros(img.shape[:2],np.uint8)

bgdModel = np.zeros((1,65),np.float64)
fgdModel = np.zeros((1,65),np.float64)

rect = (20,30,150,280)
cv2.grabCut(img,mask,rect,bgdModel,fgdModel,5,cv2.GC_INIT_WITH_RECT)
mask2 = np.where((mask==2)|(mask==0),0,1).astype('uint8')
img = img*mask2[:,:,np.newaxis]


rows,cols,channel = img.shape


for i in range(rows):
    for j in range(cols):
        k = img[i,j]
        if k[0] == 0 & k[1] == 0 & k[2] == 0:
            img[i,j]=[0,255,0]


img = cv2.rotate(img, cv2.ROTATE_90_CLOCKWISE)
cv2.imwrite('C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\dataset\\single_prediction\\MaskedImageToPredict.png', img) 




filename = 'C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\gnb_RPS.sav'
classifier = pickle.load(open(filename, 'rb'))


test_image = image.load_img('C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\dataset\\single_prediction\\MaskedImageToPredict.png', target_size = (64, 64))
test_image = image.img_to_array(test_image)
test_image = np.expand_dims(test_image, axis = 0)


       
result = classifier.predict(test_image)



print(result[0])

