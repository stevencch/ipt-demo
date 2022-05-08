import type { CSSProperties } from 'react';
export function getRowHeightStyle(height: number): CSSProperties {
    return {
        '--rdg-row-height': `${height}px`,
        'line-height': `${height}px`,
        'height': `${height}px`
    } as unknown as CSSProperties;
}