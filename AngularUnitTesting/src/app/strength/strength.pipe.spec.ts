import { StrengthPipe } from './strength.pipe';

describe('StrengthPipe', () => {
    it('should display weak if strength is 5', () => {
        const pipe = new StrengthPipe();

        expect(pipe.transform(5)).toBe('5 (weak)');
    });
});
