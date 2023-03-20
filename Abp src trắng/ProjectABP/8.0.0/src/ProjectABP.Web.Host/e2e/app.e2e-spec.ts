import { ProjectABPTemplatePage } from './app.po';

describe('ProjectABP App', function() {
  let page: ProjectABPTemplatePage;

  beforeEach(() => {
    page = new ProjectABPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
