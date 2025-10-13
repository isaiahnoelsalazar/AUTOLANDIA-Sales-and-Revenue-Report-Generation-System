﻿from reportlab.lib.pagesizes import letter
from reportlab.platypus import SimpleDocTemplate, Table, TableStyle
from reportlab.lib import colors

def export_data_to_pdf(data, filename="output.pdf"): 
    doc = SimpleDocTemplate(filename, pagesize=letter)
    elements = []
    
    table = Table(data)
    
    style = TableStyle([
        ('BACKGROUND', (0,0), (-1,0), colors.grey),
        ('TEXTCOLOR', (0,0), (-1,0), colors.whitesmoke),
        ('ALIGN', (0,0), (-1,-1), 'CENTER'),
        ('FONTNAME', (0,0), (-1,0), 'Helvetica-Bold'),
        ('BOTTOMPADDING', (0,0), (-1,0), 12),
        ('BACKGROUND', (0,1), (-1,-1), colors.beige),
        ('GRID', (0,0), (-1,-1), 1, colors.black)
    ])
    table.setStyle(style)

    elements.append(table)
    
    doc.build(elements)


data = [
    ['name', 'age'],
    ['name1', '15'],
    ['name2', '37']
]
export_data_to_pdf(data, "output.pdf")
