import cv2

img = cv2.imread('test.jpg')

img = cv2.size(img, (500, 500))

cv2.imshow('Result', img)

cv2.waitKey(0)
print(img)

images_per_class = 80
fixed_size       = tuple((500, 500))
train_path       = "dataset/train"

