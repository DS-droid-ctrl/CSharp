import cv2

img = cv2.imread('C:/Users/mdr20/Desktop/CSharp/CSharp/Butkemp/Lesson016OpenCV/test.jpg')
# print(img.shape)
# img = cv2.resize(img, (100, 100))
# print(img)
# print(img.shape)
cv2.imshow('Result', img)

cv2.waitKey(0)