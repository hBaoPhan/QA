import openpyxl
from openpyxl.drawing.image import Image as OpenpyxlImage
import os

wb = openpyxl.load_workbook('02_PhanHoaiBao_Module03.xlsx')

# Dictionary of sheet to image file and target placement cell
numbered_images = {
    'Bai08': ('Bai08_numbered.png', 'J2', 500, int(500 * (656 / 650))),
    'Bai09': ('Bai09_numbered.png', 'I2', 480, int(480 * (1700 / 1000))),
    'Bai10': ('Bai10_numbered.png', 'J2', 480, int(480 * (1280 / 1070))),
    'Bai11': ('Bai11_numbered.png', 'L2', 460, int(460 * (1730 / 1070))),
    'Bai12': ('Bai12_numbered.png', 'G2', 380, int(380 * (980 / 700))),
    'Bai13': ('Bai13_numbered.png', 'G2', 460, int(460 * (860 / 770))),
    'Bai14': ('Bai14_numbered.png', 'I2', 500, int(500 * (1050 / 1370))),
    'Bai15': ('Bai15_numbered.png', 'G2', 460, int(460 * (1470 / 1050))),
    'Bai16': ('Bai16_numbered.png', 'H2', 480, int(480 * (1610 / 1340)))
}

for sheet_name, (img_path, cell_pos, target_w, target_h) in numbered_images.items():
    if sheet_name in wb.sheetnames and os.path.exists(img_path):
        ws = wb[sheet_name]
        
        # Clear existing diagram image if present (keep existing text header if Bai08)
        if sheet_name == 'Bai08':
            # keep existing header image, just add diagram next to it
            img = OpenpyxlImage(img_path)
            img.width = target_w
            img.height = target_h
            ws.add_image(img, cell_pos)
        else:
            # for Bai09 - Bai16, clear previous images and add the numbered one
            ws._images = []
            img = OpenpyxlImage(img_path)
            img.width = target_w
            img.height = target_h
            ws.add_image(img, cell_pos)
        
        print(f"Updated {sheet_name} with {img_path} at {cell_pos} (size: {target_w}x{target_h})")

wb.save('02_PhanHoaiBao_Module03.xlsx')
print('Successfully saved updated 02_PhanHoaiBao_Module03.xlsx!')
