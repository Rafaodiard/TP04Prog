import os

template = '''<svg width="200" height="280" xmlns="http://www.w3.org/2000/svg">
  <defs>
    <linearGradient id="grad-def" x1="0%" y1="0%" x2="0%" y2="100%">
      <stop offset="0%" style="stop-color:#8BCF00;stop-opacity:1"/>
      <stop offset="100%" style="stop-color:#F5FBE8;stop-opacity:1"/>
    </linearGradient>
  </defs>

  <rect width="200" height="280" fill="url(#grad-def)" stroke="#333" stroke-width="3" rx="10"/>
  <rect x="10" y="10" width="180" height="190" fill="#ffffff" opacity="0.25" rx="8"/>

  <!-- Marco punteado -->
  <rect x="73" y="45"
        width="54"
        height="74"
        rx="6"
        fill="none"
        stroke="#0B5A20"
        stroke-width="2"
        stroke-dasharray="6 4"/>

  <text x="100" y="145"
        font-family="Arial, sans-serif"
        font-size="18"
        font-weight="bold"
        fill="#0B5A20"
        text-anchor="middle">
        FIGURITA
  </text>

  <text x="100" y="166"
        font-family="Arial, sans-serif"
        font-size="18"
        font-weight="bold"
        fill="#0B5A20"
        text-anchor="middle">
        NO PEGADA
  </text>

  <line x1="45" y1="182"
        x2="155" y2="182"
        stroke="#7BA63A"
        stroke-width="1"/>

  <text x="100" y="198"
        font-family="Arial, sans-serif"
        font-size="8"
        fill="#0B5A20"
        text-anchor="middle">
        Conseguí esta figurita
  </text>

  <text x="100" y="208"
        font-family="Arial, sans-serif"
        font-size="8"
        fill="#0B5A20"
        text-anchor="middle">
        para completar tu álbum
  </text>

  <rect x="10"
        y="225"
        width="180"
        height="45"
        fill="#ffffff"
        opacity="0.9"
        rx="8"/>

  <text x="100"
        y="245"
        font-family="Arial, sans-serif"
        font-size="12"
        font-weight="bold"
        fill="#0B5A20"
        text-anchor="middle">
        ¡AÚN NO LA TENÉS!
  </text>

  <text x="100"
        y="258"
        font-family="Arial, sans-serif"
        font-size="7"
        fill="#0B5A20"
        text-anchor="middle">
        Seguí buscando y completá tu álbum
  </text>

</svg>'''

base_path = "wwwroot/images/jugadores"

os.makedirs(base_path, exist_ok=True)

file_path = os.path.join(base_path, "def.svg")

with open(file_path, "w", encoding="utf-8") as f:
    f.write(template)

print("✓ def.svg generado correctamente")