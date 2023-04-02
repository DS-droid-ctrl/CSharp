import cv2

# face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascades_frontalface_default.xml") # для распознавани лиц
face_cascades = cv2.CascadeClassifier(r'D:/Program Files/anaconda3/Lib/site-packages/cv2/data/haarcascades_frontalface_default.xml')


# img = cv2.imread('C:/Users/mdr20/Desktop/CSharp/CSharp/Butkemp/Lesson016OpenCV/123.jpg')
# img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# faces = face_cascades.detectMultiScale(img_gray)

# for (x, y, w, h) in faces:
#     cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 0), 2)


# cv2.imshow('Result', img_gray)

# cv2.waitKey(0)


# cap = cv2.VideoCapture(0) # в скобхах кол-во камер 0 обозначает 1 камеру
cap = cv2.VideoCapture('C:/Users/mdr20/Desktop/CSharp/CSharp/Butkemp/Lesson016OpenCV/vid.mp4') # работаем с видефайлом а не камерой

while True:
    _,frame = cap.read()
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(img_gray)

    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)

    cv2.imshow("video", frame) # camera - это название камеры
    
    if cv2.waitKey(1) & 0xff == ord('q'):
        break # q для выхода из показа
