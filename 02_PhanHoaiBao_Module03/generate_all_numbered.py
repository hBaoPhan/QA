import pymupdf
import shutil
from PIL import Image, ImageDraw, ImageFont

font = ImageFont.truetype('C:/Windows/Fonts/timesbi.ttf', size=26)
scale = 200 / 72

# ==============================================================================
# BÀI 08: Use user's uploaded reference image
# ==============================================================================
shutil.copy('C:/Users/baoph/.gemini/antigravity/brain/71c88cec-d7ea-423d-807d-14409f462e44/.user_uploaded/media_1791864065118_706c4cd2.png', 'Bai08_numbered.png')
print('Bai08_numbered.png copied from user reference!')

# ==============================================================================
# BÀI 09
# ==============================================================================
doc = pymupdf.open('BaiTap_Software Testing & Quality Assurance - Ver 3.pdf')
page20 = doc[19]
pix20 = page20.get_pixmap(dpi=200)
im20 = Image.frombytes('RGB', [pix20.width, pix20.height], pix20.samples)
crop9_box = (int(120 * scale), int(55 * scale), int(480 * scale), int(670 * scale))
crop9 = im20.crop(crop9_box)
draw9 = ImageDraw.Draw(crop9)

def to_c9(pt_x, pt_y):
    return (int((pt_x - 120) * scale), int((pt_y - 55) * scale))

pos9 = {
    "1": to_c9(170, 70),
    "2": to_c9(160, 135),
    "3": to_c9(150, 212),
    "4": to_c9(125, 288),
    "5": to_c9(340, 265),
    "6": to_c9(145, 365),
    "7": to_c9(340, 342),
    "8": to_c9(145, 440),
    "9": to_c9(340, 418),
    "10": to_c9(145, 517),
    "11": to_c9(340, 495),
    "12": to_c9(150, 583),
    "13": to_c9(170, 636)
}
for k, v in pos9.items():
    draw9.text(v, k, fill='black', font=font)
crop9.save('Bai09_numbered.png')
print('Bai09_numbered.png generated!')

# ==============================================================================
# BÀI 10
# ==============================================================================
im21 = Image.open('page_21_200dpi.png')
crop10 = im21.crop((280, 140, 1350, 1420))
draw10 = ImageDraw.Draw(crop10)

pos10 = {
    "1": (530, 40),
    "2": (480, 180),
    "3": (480, 340),
    "4": (420, 490),
    "5": (920, 580),
    "6": (440, 630),
    "7": (230, 605),
    "8": (440, 780),
    "9": (230, 760),
    "10": (360, 975),
    "11": (530, 1150)
}
for k, v in pos10.items():
    draw10.text(v, k, fill='black', font=font)
crop10.save('Bai10_numbered.png')
print('Bai10_numbered.png generated!')

# ==============================================================================
# BÀI 11
# ==============================================================================
im22 = Image.open('page_22_200dpi.png')
crop11 = im22.crop((280, 140, 1350, 1870))
draw11 = ImageDraw.Draw(crop11)

pos11 = {
    "1": (130, 45),
    "2": (130, 200),
    "3": (130, 470),
    "4": (60, 700),
    "5": (800, 960),
    "6": (60, 930),
    "7": (610, 895),
    "8": (60, 1140),
    "9": (610, 1105),
    "10": (130, 1360),
    "11": (130, 1580)
}
for k, v in pos11.items():
    draw11.text(v, k, fill='black', font=font)
crop11.save('Bai11_numbered.png')
print('Bai11_numbered.png generated!')

# ==============================================================================
# BÀI 12: Pseudocode listing with clear line numbers 1 to 14
# ==============================================================================
page23 = doc[22]
pix23 = page23.get_pixmap(dpi=200)
im23 = Image.frombytes('RGB', [pix23.width, pix23.height], pix23.samples)
crop12_box = (int(50 * scale), int(45 * scale), int(300 * scale), int(400 * scale))
crop12 = im23.crop(crop12_box)
draw12 = ImageDraw.Draw(crop12)

def to_c12(pt_x, pt_y):
    return (int((pt_x - 50) * scale), int((pt_y - 45) * scale))

lines12 = {
    "1": to_c12(60, 60),
    "2": to_c12(60, 105),
    "3": to_c12(95, 127),
    "4": to_c12(60, 150),
    "5": to_c12(95, 172),
    "6": to_c12(130, 195),
    "7": to_c12(165, 217),
    "8": to_c12(130, 240),
    "9": to_c12(165, 263),
    "10": to_c12(95, 285),
    "11": to_c12(130, 308),
    "12": to_c12(60, 330),
    "13": to_c12(95, 353),
    "14": to_c12(60, 375)
}
for k, v in lines12.items():
    draw12.text(v, k, fill='black', font=font)
crop12.save('Bai12_numbered.png')
print('Bai12_numbered.png generated!')

# ==============================================================================
# BÀI 13
# ==============================================================================
crop13_box = (int(160 * scale), int(475 * scale), int(440 * scale), int(785 * scale))
crop13 = im23.crop(crop13_box)
draw13 = ImageDraw.Draw(crop13)

def to_c13(pt_x, pt_y):
    return (int((pt_x - 160) * scale), int((pt_y - 475) * scale))

pos13 = {
    "1": to_c13(205, 489),
    "2": to_c13(210, 520),
    "3": to_c13(210, 555),
    "4": to_c13(385, 540),
    "5": to_c13(210, 602),
    "6": to_c13(385, 587),
    "7": to_c13(205, 655),
    "8": to_c13(385, 640),
    "9": to_c13(230, 731),
    "10": to_c13(245, 760)
}
for k, v in pos13.items():
    draw13.text(v, k, fill='black', font=font)
crop13.save('Bai13_numbered.png')
print('Bai13_numbered.png generated!')

# ==============================================================================
# BÀI 14
# ==============================================================================
page24 = doc[23]
pix24 = page24.get_pixmap(dpi=200)
im24 = Image.frombytes('RGB', [pix24.width, pix24.height], pix24.samples)
crop14_box = (int(50 * scale), int(135 * scale), int(545 * scale), int(515 * scale))
crop14 = im24.crop(crop14_box)
draw14 = ImageDraw.Draw(crop14)

def to_c14(pt_x, pt_y):
    return (int((pt_x - 50) * scale), int((pt_y - 135) * scale))

pos14 = {
    "1": to_c14(230, 148),
    "2": to_c14(180, 215),
    "3": to_c14(245, 263),
    "4": to_c14(485, 245),
    "5": to_c14(255, 317),
    "6": to_c14(435, 300),
    "7": to_c14(100, 375),
    "8": to_c14(340, 360),
    "9": to_c14(200, 420),
    "10": to_c14(310, 490)
}
for k, v in pos14.items():
    draw14.text(v, k, fill='black', font=font)
crop14.save('Bai14_numbered.png')
print('Bai14_numbered.png generated!')

# ==============================================================================
# BÀI 15
# ==============================================================================
page25 = doc[24]
pix25 = page25.get_pixmap(dpi=200)
im25 = Image.frombytes('RGB', [pix25.width, pix25.height], pix25.samples)
crop15_box = (int(30 * scale), int(60 * scale), int(410 * scale), int(590 * scale))
crop15 = im25.crop(crop15_box)
draw15 = ImageDraw.Draw(crop15)

def to_c15(pt_x, pt_y):
    return (int((pt_x - 30) * scale), int((pt_y - 60) * scale))

pos15 = {
    "1": to_c15(70, 73),
    "2": to_c15(80, 120),
    "3": to_c15(70, 168),
    "4": to_c15(355, 155),
    "5": to_c15(70, 233),
    "6": to_c15(340, 215),
    "7": to_c15(60, 313),
    "8": to_c15(340, 295),
    "9": to_c15(50, 415),
    "10": to_c15(330, 395),
    "11": to_c15(90, 528),
    "12": to_c15(120, 568)
}
for k, v in pos15.items():
    draw15.text(v, k, fill='black', font=font)
crop15.save('Bai15_numbered.png')
print('Bai15_numbered.png generated!')

# ==============================================================================
# BÀI 16
# ==============================================================================
page26 = doc[25]
pix26 = page26.get_pixmap(dpi=200)
im26 = Image.frombytes('RGB', [pix26.width, pix26.height], pix26.samples)
crop16_box = (int(70 * scale), int(70 * scale), int(555 * scale), int(650 * scale))
crop16 = im26.crop(crop16_box)
draw16 = ImageDraw.Draw(crop16)

def to_c16(pt_x, pt_y):
    return (int((pt_x - 70) * scale), int((pt_y - 70) * scale))

pos16 = {
    "1": to_c16(110, 85),
    "2": to_c16(85, 160),
    "3": to_c16(140, 218),
    "4": to_c16(180, 260),
    "5": to_c16(260, 277),
    "6": to_c16(265, 335),
    "7": to_c16(435, 315),
    "8": to_c16(290, 390),
    "9": to_c16(240, 448),
    "10": to_c16(370, 452),
    "11": to_c16(290, 513),
    "12": to_c16(440, 555),
    "13": to_c16(160, 625)
}
for k, v in pos16.items():
    draw16.text(v, k, fill='black', font=font)
crop16.save('Bai16_numbered.png')
print('Bai16_numbered.png generated!')
