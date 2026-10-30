import json
import os

with open('C:/Users/baoph/.gemini/antigravity/brain/71c88cec-d7ea-423d-807d-14409f462e44/.system_generated/logs/transcript_full.jsonl', 'r', encoding='utf-8', errors='ignore') as f:
    for line in f:
        obj = json.loads(line)
        idx = obj.get('step_index', 0)
        tc = obj.get('tool_calls', [])
        for call in tc:
            fn = call.get('function', {})
            name = fn.get('name', '')
            args = fn.get('arguments', {})
            if 'TargetFile' in args:
                tf = args['TargetFile']
                if 'generate_all_numbered' in tf or 'update_excel_images' in tf:
                    print(f'=== STEP {idx}: {tf} ===')
                    with open(os.path.basename(tf), 'w', encoding='utf-8') as out:
                        out.write(args['CodeContent'])
                    print(f'Restored {os.path.basename(tf)}')
